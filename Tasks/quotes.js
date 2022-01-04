// Change douple quotation to open or close quotation
'use strict';

const EMPTY = '';

const quotes = str => {
  let res = [];
  let isBracketOpen = false;
  for (let element of str) {
    if (element === '"') {
      if (!isBracketOpen) {
        element = '«';
        isBracketOpen = true;
      } else {
        element = '»';
        isBracketOpen = false;
      }
    }
    res.push(element);
  }
  return res.join(EMPTY);
}

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);
