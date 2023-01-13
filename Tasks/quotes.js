// Change double quotation to open or close quotation
'use strict'

const EMPTY = '';

const quotes = function (inputString) {
  let outputString = [];
  let open = false;
  for (const SYMBOL of inputString) {
    if (SYMBOL === '"') {
      for (let i of SYMBOL) {
        if (!open) {
          outputString.push('«');
          open = true;
        } else {
          outputString.push('»');
          open = false;
        }
      }
    } else {
      if (SYMBOL !== '"') {
        for (let i of SYMBOL) {
          res.push(i);
        }
      }
    }
  }
  return outputString.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
