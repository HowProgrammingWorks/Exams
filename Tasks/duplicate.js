//step2 
//used while instead of for of
//reduced code in function, used push method

const duplicate = (value, N) => {
  const res = [];
  if (N <= 0) res;
  while (res.length < N) {
      res.push(value);
  }
  return res;
};

require('../Tests/duplicate.js')(duplicate);