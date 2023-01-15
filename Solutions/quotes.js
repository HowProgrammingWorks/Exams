// Change double quotation to open or close quotation

const EMPTY = '';

quotes = function (s) {
  res = [];
  open = false;
  for (c of s) {
    if (c === '"') {
      for (i of c) {
        if (!open) {
          res.push('«');
          open = true;
        } else {
          res.push('»');
          open = false;
        }
      }
    } else {
      if (c !== '"') {
        for (i of c) {
          res.push(i);
        }
      }
    }
  }
  return res.join(EMPTY);
};

require('../Tests/quotes.js')(quotes);
