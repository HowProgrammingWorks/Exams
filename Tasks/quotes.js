// Change double quotation to open or close quotation

'use strict';

const quotes = (s) => {
  const res = [];
  let open = false;
  for (const c of s) {
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
  return res.join('');
};

require('../Tests/quotes.js')(quotes);
