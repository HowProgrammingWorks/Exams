// Change double quotation to open or close quotation

'use strict';

const quotes = (string) => {
  const result = [];
  let open = false;
  for (let char of string) {
    if (char === '"') {
      !open ? char = '«' : char = '»';
      open = !open;
    }
    result.push(char);
  }
  return result.join('');
};

require('../Tests/quotes.js')(quotes);
