// Copy only listed values from dict

only = (dictionary, ...only) => {
  keys = Object.keys(dictionary, 'a', 'b', 'c');
  keys.forEach((Z) => {
    if (only.includes(Z)) {
    } else {
      delete dictionary[Z];
    }
  });
  return dictionary;
};

require('../Tests/only.js')(only);
