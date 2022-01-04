// Change douple quotation to open or close quotation
'use strict';

const EMPTY = '';
const BRACKETS = ['«', '»'];

const quotes = str => {
  let indexBracket = 0;
  return str.split(EMPTY).map( element => {
    if (element === '"') {
      element = BRACKETS[(indexBracket++) % 2];
    }
    return element;
  }).join(EMPTY);
}

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);
