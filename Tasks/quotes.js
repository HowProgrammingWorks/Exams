// Change double quotation to open or close quotation

'use strict';

const EMPTY = '';

const quotes = function (s) {
  const res = [];
  let open = false;
  for (const c of s) {
    if (c === '"') {
      for (const i of c) {
        if (!open) {
          res.push('«');
          open = true;
        } else {
          res.push('»');
          open = false;
        }
      }
    } else {
      if (c !== '"') {
        for (const i of c) {
          res.push(i);
        }
      }
    }
  }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
