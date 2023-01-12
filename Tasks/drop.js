// Delete listed keys from dictionary
'use strict';

const drop = (dictionary, ...keys) => {
  const dictionaryKeys = Object.keys(dictionary);
  for (const key of keys) {
    if (dictionaryKeys.includes(key)) {
      delete dictionary[key];
    }
  }
  return dictionary;
};

require('../Tests/drop.js')(drop);
