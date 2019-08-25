import { Component } from '@angular/core';

@Component({
  selector: 'account-component',
  templateUrl: './account.component.html'
})
export class AccountComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
