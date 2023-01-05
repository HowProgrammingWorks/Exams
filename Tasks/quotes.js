// Change double quotation to open or close quotation

'use strict';

const EMPTY = '';

const quotes = (string) => {
  const res = [];
  let open = false;
  for (const symbol of string) {
    if (symbol === '"') {
      if (!open) {
        res.push('«');
        open = true;
      } else {
        res.push('»');
        open = false;
      }
    } else res.push(symbol);
  }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
