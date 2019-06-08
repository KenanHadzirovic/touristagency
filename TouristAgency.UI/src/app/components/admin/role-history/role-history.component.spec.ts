import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoleHistoryComponent } from './role-history.component';

describe('RoleHistoryComponent', () => {
  let component: RoleHistoryComponent;
  let fixture: ComponentFixture<RoleHistoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoleHistoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoleHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
