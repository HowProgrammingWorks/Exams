// Change double quotation to open or close quotation
'use strict'

const quotes = function (inputString) {
  let outputString = '';
  let open = false;
  for (const SYMBOL of inputString) {
    if (SYMBOL === '"') {
        if (!open) {
          outputString += '«';
          open = true;
        } 
        else {
          outputString += '»';
          open = false;
      }
    } 
    else outputString += SYMBOL;
  }
  return outputString;
};

require('../Tests/quotes.js')(quotes);
