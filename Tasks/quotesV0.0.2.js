'use strict';
// Change double quotation to open or close quotation

const quotes = (str) => {
  const res = new Array(str.length);
  const brackets = [ '«', '»' ];
  let curBracket = 0;

  for (const char of str) {
    if (char !== '"') {
      res.push(char);
      continue;
    }

    const bracket = brackets[curBracket];
    res.push(bracket);
    curBracket = (curBracket + 1) % 2;
  }

  return res.join('');
};

require('../Tests/quotes.js')(quotes);
