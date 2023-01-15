'use strict'

const EMPTY = '';

const quotes = function (s) {
  let res = [];
  let open = false;
  for (let c of s) {
      for (let i of c) {
        if (!open && c === '"') {
          res.push('«');
          open = true;
        } else if (open && c === '"') {
          res.push('»');
          open = false;
        } else if (c !== '"') {
          res.push(i);
        }
      }
    }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
