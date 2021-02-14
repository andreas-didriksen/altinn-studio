/// <reference types='cypress' />

import * as af from '../../pageobjects/app-frontend';

const appName = Cypress.env('localTestAppName');

describe('Message', () => {
  before(() => {
    cy.visit(Cypress.env('localTestBaseUrl'));
    cy.get(af.appSelection).select(appName);
    cy.get(af.startButton).click();
    cy.get(af.closeButton).should('be.visible');
  });

  //verifies that attachments list component displays the correct number of attachments
  it('Attachments List', async() => {
    cy.get(af.message['header']).should('exist');
    cy.getTokenForOrg('ttd').then(token => {
      cy.url().then(instance => {
        instance = instance.split('/');
        cy.uploadAttachment('ttd', 'frontend-test', instance[instance.length - 2], instance[instance.length - 1], 'fileUpload-message', token)
          .then(() => cy.reload());
      });
    });
    cy.get(af.message['attachmentList']).siblings('ul').children('a')
      .then((attachments) => {
        cy.get(attachments).should('have.length', 1);
        cy.get(attachments).first().should('contain.text', af.downloadAttachment);
        cy.get(af.attachmentIcon).should('be.visible');
      });
  });

});