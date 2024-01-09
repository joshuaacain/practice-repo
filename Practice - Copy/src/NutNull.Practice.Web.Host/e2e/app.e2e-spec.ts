import { PracticeTemplatePage } from './app.po';

describe('Practice App', function() {
  let page: PracticeTemplatePage;

  beforeEach(() => {
    page = new PracticeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
