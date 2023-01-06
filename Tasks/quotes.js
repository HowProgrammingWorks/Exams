'use strict';
// Change double quotation to open or close quotation

const quotes = (str) => {
  const res = [];
  let isOpen = true;
  for (const char of str) {
    if (char === '"') {
      if (isOpen) {
        res.push('«');
        isOpen = false;
      } else {
        res.push('»');
        isOpen = true;
      }
    } else {
      res.push(char);
    }
  }
  return res.join('');
};

require('../Tests/quotes.js')(quotes);
