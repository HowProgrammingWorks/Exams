// Change double quotation to open or close quotation
'use strict'

const quotes = function (inputString) {
  let outputString = '';
  let open = false;
  for (const SYMBOL of inputString) {
    if (SYMBOL === '"') {
      for (let i of SYMBOL) {
        if (!open) {
          outputString += '«';
          open = true;
        } else {
          outputString += '»';
          open = false;
        }
      }
    } else {
      if (SYMBOL !== '"') {
        for (let i of SYMBOL) {
          outputString += i;
        }
      }
    }
  }
  return outputString;
};

require('../Tests/quotes.js')(quotes);
