import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public allEmployees: Employee[] = [];
  public employees: Employee[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Employee[]>(baseUrl + 'employee').subscribe(result => {
      this.allEmployees = result;
      this.employees = this.allEmployees;
    }, error => console.error(error));
  }

  filterEmployees(event: any) {
    let val = event.target.value;
    if (val > 0) {
      this.employees = this.employees.filter(x => x.id == Number(val));
    } else {
      this.employees = this.allEmployees;
    }
  }
}

interface Employee {
  name: string;
  email: string;
  streetAddress: string;
  pets: string;
  id: number;
}
