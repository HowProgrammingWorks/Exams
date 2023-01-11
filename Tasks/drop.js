// Delete listed keys from dictionary
'use strict';

const drop = (dictionary, ...keys) => {
  const dictionaryKeys = Object.keys(dictionary);
  const length = keys.length;
  for (let i = 0; i < length; i++) {
    if (dictionaryKeys.includes(keys[i])) {
      delete dictionary[keys[i]];
    }
  }
  return dictionary;
};

require('../Tests/drop.js')(drop);
