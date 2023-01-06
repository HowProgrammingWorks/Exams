'use strict';
// Change double quotation to open or close quotation

const quotes = (str) => {
  const res = [];
  const brackets = {
    'open': '«',
    'close': '»',
  };
  let curBracket = 'open';

  for (const char of str) {
    if (char !== '"') {
      res.push(char);
      continue;
    }

    const bracket = brackets[curBracket];
    res.push(bracket);
    curBracket = curBracket === 'open' ? 'close' : 'open';
  }

  return res.join('');
};

require('../Tests/quotes.js')(quotes);
