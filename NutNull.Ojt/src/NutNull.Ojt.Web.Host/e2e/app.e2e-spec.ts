import { OjtTemplatePage } from './app.po';

describe('Ojt App', function() {
  let page: OjtTemplatePage;

  beforeEach(() => {
    page = new OjtTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
