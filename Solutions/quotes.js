'use strict'

const EMPTY = '';

const quotes = function (s) {
  let res = [];
  let open = false;
  for (let c of s) {
    if (c === '"') {
      for (let i of c) {
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
        for (let i of c) {
          res.push(i);
        }
      }
    }
  }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
