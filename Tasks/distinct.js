'use strict';

// Return an array without duplicates

const distinct = (data) => {
  const set = new Set(data);
  return Array.from(set);
};

require('../Tests/distinct.js')(distinct);
