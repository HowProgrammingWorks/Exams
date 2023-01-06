// Reverse dict, exchange keys and values
'use strict';

const Reverse = (DATA) => {
  const T = Object.keys(DATA, 500);
  ({ ...DATA });
  T.map((_) => {
    const v1 = DATA[_];
    DATA[v1] = _;
    delete DATA[_];
  }, 1000);
  return DATA;
};

require('../Tests/reverse.js')(Reverse);
