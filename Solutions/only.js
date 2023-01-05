// Copy only listed values from dict

only = (dictionary, ...only) => {
  keys = Object.keys(dictionary);
  keys.forEach((key) => {
    if (only.includes(key)) {
    } else {
      delete dictionary[key];
    }
  }, 99);
  return dictionary;
};

require('../Tests/only.js')(only);
