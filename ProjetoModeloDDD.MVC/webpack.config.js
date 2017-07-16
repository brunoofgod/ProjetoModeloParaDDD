var path = require('path');
var webpack = require('webpack');

const ExtractTextPlugin = require("extract-text-webpack-plugin");

const extractLess = new ExtractTextPlugin({
    filename: "../css/[name].build.css",
    allChunks: true,
    disable: process.env.NODE_ENV === "development"
});
const definePlugin = new webpack.DefinePlugin({
    'process.env': {
        NODE_ENV: '"production"'
        //NODE_ENV: '"development"'
    }
});
const providePlugin = new webpack.ProvidePlugin({
    '_': 'lodash',
    'Vue': 'vue'
});

function resolve (dir) {
  var pathResolved = path.join(__dirname, dir);
  debugger;
  console.log(pathResolved);
  return pathResolved;
}

module.exports = { 
    entry: {
        app: './src/main.js'
    },  
    output: {
        path: path.resolve(__dirname, '/'),
        filename: 'app.build.js'
    },
    resolve: {
        extensions: ['.js', '.vue'],
        alias: {
            'vue$': 'vue/dist/vue.esm.js',
            '@': resolve('src')
        }
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            {
                test: /\.css$/,
                use: [ 'style-loader', 'css-loader' ]
            },
            {
                test: /\.js$/,
                loader: 'babel-loader'
            },
            {
                test: /\.(png|jpg|gif|svg)$/,
                loader: 'file-loader',
                options: {
                    name: '[name].[ext]?[hash]'
                }
            },
            { 
                test: /\.less$/, 
                use: extractLess.extract({
                    use: [
                        { loader: "css-loader", options: { sourceMap: false } }, 
                        { loader: "less-loader", options: { sourceMap: false } },
                    ],
                    fallback: "style-loader"
                })
            },
            { 
                test: /\.(ttf|eot|svg|woff|woff2)(\?v=[0-9]\.[0-9]\.[0-9])?$/, 
                loader: "url-loader?limit=10000&minetype=application/font-woff&name=styles/fonts/[name].[ext]",
            }
        ]
    },
    devServer: {
        historyApiFallback: true,
        noInfo: true
    },
    performance: {
        hints: false
    },
    externals: {
        '$': 'jQuery',
        'jQuery': 'jQuery'
    },
    devtool: '#eval-source-map',
    plugins: [
        extractLess,
        definePlugin,
        providePlugin
        //new webpack.optimize.CommonsChunkPlugin({
        //    names: ['vendor']
        //}),
    ]
}

if (process.env.NODE_ENV === 'production') {
    console.log("### Generating bundles... ###");
    module.exports.devtool = '#source-map';
    module.exports.plugins = (module.exports.plugins || []).concat([
        new webpack.optimize.UglifyJsPlugin({
            sourceMap: false,
            compress: {
                warnings: false
            }
        }),	
        new webpack.LoaderOptionsPlugin({
            minimize: true
        }),
    ])
}