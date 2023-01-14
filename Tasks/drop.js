'use strict';

// Delete listed keys from dictionary
const dropKeys = (obj, ...keys) => {
  Object.keys(obj).forEach(
    (key) => {
      if (keys.includes(key)) {
        delete obj[key];
      }
    }
  );
  return obj;
};

require('../Tests/drop.js')(dropKeys);
