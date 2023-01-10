// Copy only listed values from dict

only = (dictionary, ...only) => {
  keys = Object.keys(dictionary);
  keys.forEach((currentKey) => {
    if (only.includes(currentKey)) {
    } else {
      delete dictionary[currentKey];
    }
  });
  return dictionary;
};

require('../Tests/only.js')(only);
