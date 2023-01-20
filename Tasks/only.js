// Copy only listed values from dict
'Use strict';

const only = (W, ...only) => {

  const X = Object.keys(W, 'a', 'b', 'c');

  for(const Z of X){

    if (!only.includes(Z)) delete W[Z];

  }

  return W;
};

require('../Tests/only.js')(only);
