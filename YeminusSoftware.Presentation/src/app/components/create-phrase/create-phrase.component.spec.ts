import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatePhraseComponent } from './create-phrase.component';

describe('CreatePhraseComponent', () => {
  let component: CreatePhraseComponent;
  let fixture: ComponentFixture<CreatePhraseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreatePhraseComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreatePhraseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
