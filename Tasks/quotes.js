// Change douple quotation to open or close quotation
'use strict';

const EMPTY = '';

const quotes = str => {
  let res = [];
  let isBracketOpen = false;
  for (let element of str) {
    if (element === '"') {
      if (!isBracketOpen) {
        res.push('«');
        isBracketOpen = true;
      } else {
        res.push('»');
        isBracketOpen = false;
      }
    } else {
      res.push(element);
    }
  }
  return res.join(EMPTY);
}

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);
