const path = require('path');
const manifest = require('./scripts.bundle.json');
const bundles = manifest.bundles.filter((bundle) => {
	return bundle.hasOwnProperty('webpack') && bundle.webpack;
});
let entries = {};

bundles.map((bundle) => {
	let key = buildKey(bundle.path);
	entries[key] = buildFilepath(bundle.files[0]);
});

function buildKey(bundleName) {
	return bundleName.endsWith('.js')
		? bundleName
		: bundleName + '.js';
}

function buildFilepath(filePath) {
	return filePath.startsWith('./')
		? filePath
		: './' + filePath;
}
module.exports = {
	entry: {
		tutorial: [
			'./jsx/tutorial.jsx'
		]
	},
	module: {
		rules: [
			{
				test: /\.(js|jsx)$/,
				exclude: /node_modules/,
				use: {
					loader: 'babel-loader'
				}
			}
		]
	},
	output: {
		path: path.resolve(__dirname,'./wwwroot/js'),
		filename: '[name].bundle.js'
	}
};