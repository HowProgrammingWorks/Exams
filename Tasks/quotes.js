// Change double quotation to open or close quotation

'use strict';

const quotes = (string) => {
  let res = '';
  let open = false;
  for (const symbol of string) {
    if (symbol === '"') {
      if (!open) {
        res += '«';
        open = true;
      } else {
        res += '»';
        open = false;
      }
    } else res += symbol;
  }
  return res;
};

require('../Tests/quotes.js')(quotes);
