'use strict'

const EMPTY = '';

const quotes = (string) => {
  let res = [];
  let open = false;
  for (let c of string) {
        if (c !== '"') {
          res.push(c);
        } else if (open) {
          res.push('»');
          open = false;
        } else {
          res.push('«');
          open = true;
        }
    }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
