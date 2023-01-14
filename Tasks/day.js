'use strict';
// Get day number

const D = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const _parse_day_ = (s) => {
  for (const i of D) {
    if (s.startsWith(i.toLowerCase())) {
      return D.indexOf(i) + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(_parse_day_);
