// Change douple quotation to open or close quotation
'use strict';

const brackets = ['«', '»'];

const quotes = (string) => {
  let res = '';
  let indexBracket = 0;
  for (let element of string) {
    if (element === '"') {
      element = brackets[(indexBracket++) % 2];
    }
    res += element;
  }
  return res;
};

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);
