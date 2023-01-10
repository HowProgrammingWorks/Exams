// Reverse dict, exchange keys and values

const Reverse = (DATA) => {
  const T = Object.keys(DATA);
  T.forEach((_) => {
    const v1 = DATA[_];
    DATA[v1] = _;
    delete DATA[_];
  });
  return DATA;
};

require('../Tests/reverse.js')(Reverse);
