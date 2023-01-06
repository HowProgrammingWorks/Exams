'use strict';
// Change double quotation to open or close quotation

const EMPTY = '';

const quotes = (str) => {
  const res = [];
  let open = false;
  for (const char of str) {
    if (char === '"') {
      for (const i of char) {
        if (!open) {
          res.push('«');
          open = true;
        } else {
          res.push('»');
          open = false;
        }
      }
    } else {
      if (char !== '"') {
        for (const i of char) {
          res.push(i);
        }
      }
    }
  }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
