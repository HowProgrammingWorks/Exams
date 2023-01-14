'use strict';

// Delete listed keys from dictionary
const dropKeys = (obj, ...keys) => {
  for (const key of Object.keys(obj)) {
    if (keys.includes(key))
      delete obj[key];
  }
  return obj;
};

require('../Tests/drop.js')(dropKeys);
