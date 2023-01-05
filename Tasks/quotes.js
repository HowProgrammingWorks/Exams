// Change double quotation to open or close quotation

'use strict';

const quotes = (string) => {
  let res = '';
  let odd = true;
  for (const symbol of string) {
    if (symbol === '"') {
      res += (odd? '«': '»');
      odd = !odd;
    } else res += symbol;
  }
  return res;
};

require('../Tests/quotes.js')(quotes);
