import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { MaterialModule } from '@shared/material';

import { HeaderComponent } from '@shared/components/header';

const components = [
  HeaderComponent
];

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [...components]
})
export class ComponentsModule { }
