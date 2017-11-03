import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CarServiceProxy, CarDto, PagedResultDtoOfCarDto } from '@shared/service-proxies/service-proxies';

import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { EditCarComponent } from "app/cars/edit-car/edit-car.component";
import { CreateCarComponent } from "app/cars/create-car/create-car.component";

@Component({
    templateUrl: './cars.component.html',
    animations: [appModuleAnimation()]
})
export class CarsComponent extends PagedListingComponentBase<CarDto> {

    @ViewChild('createCarModal') createCarModal: CreateCarComponent;
    @ViewChild('editCarModal') editCarModal: EditCarComponent;

    cars: CarDto[] = [];

    constructor(
        injector: Injector,
        private _carService: CarServiceProxy
    ) {
        super(injector);
    }

    list(request:PagedRequestDto, pageNumber:number, finishedCallback: Function): void {
        this._carService.getAll(request.skipCount, request.maxResultCount)
            .finally(()=>{
                finishedCallback();
            })
            .subscribe((result:PagedResultDtoOfCarDto)=>{
				this.cars = result.items;
				this.showPaging(result, pageNumber);
            });
    }

    delete(car: CarDto): void {
		abp.message.confirm(
			"Delete Car '"+ car.name +"'?",
			(result:boolean) => {
				if(result) {
					this._carService.delete(car.id)
						.finally(() => {
					        abp.notify.info("Deleted Car: " + car.name );
							this.refresh();
						})
						.subscribe(() => { });
				}
			}
		);
    }

    // Show modals
    createCar(): void {
        this.createCarModal.show();
    }

    editCar(car:CarDto): void{
        this.editCarModal.show(car.id);
    }
}