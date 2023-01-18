// Get day number

"use strict";

const days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const _parse_day_ = (s) => {
  for (let index = 0; index < days.length; index++) {
    const checkCase = s.startsWith(days[index].toLowerCase());
    if (checkCase) return ++index;
  }
  return -1;
};

require("../Tests/day.js")(_parse_day_);
