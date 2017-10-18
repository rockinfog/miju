import { AowenPlatformTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: AowenPlatformTemplatePage;

  beforeEach(() => {
    page = new AowenPlatformTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
