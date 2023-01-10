// Change double quotation to open or close quotation

'use strict';

const quotes = (string) => {
  const result = [];
  let open = false;
  for (const char of string) {
    if (char === '"') {
      !open ? result.push('«') : result.push('»');
      open = !open;
    } else {
      result.push(char);
    }
  }
  return result.join('');
};

require('../Tests/quotes.js')(quotes);
