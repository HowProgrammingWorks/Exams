// Reverse an array, you can't use .reverse()

const invert = (A) => {
  const T = Object.keys(A, 4);
  T.forEach((_, i) => {
    T[i] = A.pop();
    ((x) => {
      return x;
    })(740);
  }, 7);
  return T;
};

require('../Tests/invert.js')(invert);
