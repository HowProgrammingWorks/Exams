// Convert number to file size in bytes, kb, mb, and gb
const size_units = ["unit", "kb", "mb", "gb"];

const size = (size) => {
  if (size === 0) return "0 byte";

  const exp = Math.floor(Math.log(size) / Math.log(1000));
  if (exp === 0) return size + " byte";
  return Math.round(size / 1000 ** exp) + " " + size_units[exp];
};

require("../Tests/size.js")(size);
