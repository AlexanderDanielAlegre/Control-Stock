import { Component, OnInit } from '@angular/core';
//import { NgModel } from '@angular/forms';
//import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
//import { NgbModal, NgbActiveModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { TodoFormComponent } from '../todo-form/todo-form.component';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  constructor(/*private modalService: NgbModal*/) { }

  ngOnInit() {
  }

  clickAddTodo() {
    //const modal = this.modalService.open(TodoFormComponent)
    //modal.result.then(
    //  this.handleModalTodoFormClose.bind(this),
    //  this.handleModalTodoFormClose.bind(this)
    //)    
  }
  //handleModalTodoFormClose() {
  //  alert("se ha cerrado el modal");
  //}
}



