// Change double quotation to open or close quotation

'use strict';

const quotes = (string) => {
  const result = [];
  let open = false;
  for (const char of string) {
    if (char === '"') {
      if (!open) {
        result.push('«');
        open = true;
      } else {
        result.push('»');
        open = false;
      }
    } else {
      result.push(char);
    }
  }
  return result.join('');
};

require('../Tests/quotes.js')(quotes);
