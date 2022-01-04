// Change douple quotation to open or close quotation
'use strict';

const EMPTY = '';

const quotes = s => {
  let res = [];
  let open = false;
  for (let c of s) {
    if (c === '"') {
      if (!open) {
        res.push('«');
        open = true;
      } else {
        res.push('»');
        open = false;
      }
    } else {
      res.push(c);
    }
  }
  return res.join(EMPTY);
}

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);
