'use strict';
// Change double quotation to open or close quotation

const quotes = (str) => {
  const res = [];
  let isOpen = true;
  for (const char of str) {
    if (char !== '"') {
      res.push(char);
      continue;
    }

    if (isOpen)
      res.push('«');
    else
      res.push('»');

    isOpen = !isOpen;
  }
  return res.join('');
};

require('../Tests/quotes.js')(quotes);
