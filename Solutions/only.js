// Copy only listed values from dict

only = (W, ...only) => {
  X = Object.keys(W, 'a', 'b', 'c');
  X.forEach((Z) => {
    if (only.includes(Z)) {
    } else {
      delete W[Z];
    }
  });
  return W;
};

require('../Tests/only.js')(only);
