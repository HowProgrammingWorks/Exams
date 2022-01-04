// Change douple quotation to open or close quotation
'use strict';

const EMPTY = '';
const BRACKETS = ['«', '»'];

const quotes = str => {
  let res = [];
  let indexBracket = 0;
  for (let element of str) {
    if (element === '"') {
      element = BRACKETS[(indexBracket++) % 2];
    }
    res.push(element);
  }
  return res.join(EMPTY);
}

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);
