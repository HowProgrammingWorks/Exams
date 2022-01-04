// Push single value multiple times
'use string';
duplicate = (value, N) => {
  if (N <= 0) {
    return [];
  } else {
    res = [];
    for (let i = 0; i < N; i++) {
      res[i] = value;
    }
    return res;
  }
};

const string = 'abc';
const number = 5;
const result = duplicate(string , number);
console.log(result);
