import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef} from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { CarServiceProxy, CarDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

import * as _ from "lodash";

@Component({
  selector: 'edit-car-modal',
  templateUrl: './edit-car.component.html'
})
export class EditCarComponent extends AppComponentBase{

    @ViewChild('editCarModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;
    car: CarDto = null;

    constructor(
        injector: Injector,
        private _carService: CarServiceProxy
    ) {
        super(injector);
    }

    show(id:number): void {
		this._carService.get(id)
			.finally(()=>{
				this.active = true;
				this.modal.show();
			})
			.subscribe((result: CarDto)=>{
				this.car = result;
			});
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        this.saving = true;
        this._carService.update(this.car)
            .finally(() => { this.saving = false; })
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
