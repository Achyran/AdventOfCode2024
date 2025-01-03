﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    internal class Day5 : IDay
    {
        public string input => "31|94\r\n98|37\r\n98|49\r\n25|17\r\n25|22\r\n25|44\r\n89|84\r\n89|66\r\n89|32\r\n89|72\r\n97|31\r\n97|33\r\n97|51\r\n97|67\r\n97|23\r\n94|96\r\n94|11\r\n94|53\r\n94|47\r\n94|36\r\n94|89\r\n56|23\r\n56|76\r\n56|33\r\n56|88\r\n56|64\r\n56|62\r\n56|11\r\n67|47\r\n67|72\r\n67|56\r\n67|87\r\n67|54\r\n67|33\r\n67|62\r\n67|84\r\n87|42\r\n87|19\r\n87|98\r\n87|47\r\n87|11\r\n87|24\r\n87|71\r\n87|53\r\n87|21\r\n17|72\r\n17|18\r\n17|51\r\n17|94\r\n17|62\r\n17|49\r\n17|27\r\n17|84\r\n17|37\r\n17|68\r\n32|56\r\n32|72\r\n32|87\r\n32|67\r\n32|15\r\n32|94\r\n32|96\r\n32|71\r\n32|76\r\n32|31\r\n32|78\r\n49|23\r\n49|33\r\n49|79\r\n49|68\r\n49|88\r\n49|15\r\n49|87\r\n49|71\r\n49|36\r\n49|85\r\n49|96\r\n49|53\r\n64|97\r\n64|78\r\n64|36\r\n64|59\r\n64|89\r\n64|25\r\n64|79\r\n64|98\r\n64|34\r\n64|44\r\n64|24\r\n64|53\r\n64|55\r\n96|64\r\n96|71\r\n96|47\r\n96|53\r\n96|21\r\n96|44\r\n96|77\r\n96|25\r\n96|42\r\n96|79\r\n96|66\r\n96|17\r\n96|87\r\n96|55\r\n53|17\r\n53|59\r\n53|79\r\n53|14\r\n53|78\r\n53|51\r\n53|32\r\n53|24\r\n53|55\r\n53|44\r\n53|84\r\n53|19\r\n53|34\r\n53|67\r\n53|77\r\n55|24\r\n55|77\r\n55|59\r\n55|89\r\n55|66\r\n55|13\r\n55|51\r\n55|25\r\n55|42\r\n55|84\r\n55|34\r\n55|97\r\n55|14\r\n55|98\r\n55|44\r\n55|31\r\n54|25\r\n54|24\r\n54|88\r\n54|44\r\n54|97\r\n54|64\r\n54|11\r\n54|19\r\n54|47\r\n54|32\r\n54|42\r\n54|14\r\n54|55\r\n54|79\r\n54|21\r\n54|89\r\n54|77\r\n51|71\r\n51|84\r\n51|13\r\n51|33\r\n51|15\r\n51|68\r\n51|31\r\n51|76\r\n51|85\r\n51|37\r\n51|27\r\n51|87\r\n51|22\r\n51|64\r\n51|18\r\n51|94\r\n51|72\r\n51|23\r\n85|79\r\n85|22\r\n85|55\r\n85|89\r\n85|54\r\n85|68\r\n85|87\r\n85|88\r\n85|96\r\n85|47\r\n85|21\r\n85|62\r\n85|64\r\n85|23\r\n85|94\r\n85|11\r\n85|27\r\n85|59\r\n85|15\r\n22|68\r\n22|79\r\n22|14\r\n22|59\r\n22|77\r\n22|94\r\n22|55\r\n22|47\r\n22|23\r\n22|71\r\n22|87\r\n22|53\r\n22|62\r\n22|27\r\n22|21\r\n22|54\r\n22|36\r\n22|15\r\n22|96\r\n22|42\r\n21|89\r\n21|14\r\n21|98\r\n21|59\r\n21|67\r\n21|13\r\n21|55\r\n21|42\r\n21|24\r\n21|34\r\n21|19\r\n21|17\r\n21|88\r\n21|79\r\n21|66\r\n21|78\r\n21|51\r\n21|53\r\n21|97\r\n21|77\r\n21|84\r\n68|89\r\n68|19\r\n68|24\r\n68|25\r\n68|27\r\n68|11\r\n68|77\r\n68|59\r\n68|44\r\n68|79\r\n68|21\r\n68|64\r\n68|36\r\n68|54\r\n68|71\r\n68|55\r\n68|88\r\n68|47\r\n68|87\r\n68|53\r\n68|14\r\n68|96\r\n62|47\r\n62|59\r\n62|54\r\n62|88\r\n62|25\r\n62|42\r\n62|44\r\n62|53\r\n62|27\r\n62|79\r\n62|96\r\n62|94\r\n62|87\r\n62|97\r\n62|55\r\n62|68\r\n62|36\r\n62|21\r\n62|64\r\n62|89\r\n62|14\r\n62|71\r\n62|11\r\n15|87\r\n15|88\r\n15|14\r\n15|53\r\n15|96\r\n15|89\r\n15|47\r\n15|68\r\n15|27\r\n15|21\r\n15|64\r\n15|44\r\n15|11\r\n15|54\r\n15|36\r\n15|42\r\n15|94\r\n15|71\r\n15|62\r\n15|25\r\n15|59\r\n15|79\r\n15|77\r\n15|55\r\n78|62\r\n78|87\r\n78|31\r\n78|18\r\n78|94\r\n78|49\r\n78|84\r\n78|85\r\n78|76\r\n78|67\r\n78|22\r\n78|72\r\n78|23\r\n78|56\r\n78|13\r\n78|27\r\n78|37\r\n78|54\r\n78|68\r\n78|15\r\n78|51\r\n78|96\r\n78|33\r\n78|71\r\n84|87\r\n84|49\r\n84|23\r\n84|33\r\n84|94\r\n84|47\r\n84|85\r\n84|27\r\n84|62\r\n84|68\r\n84|76\r\n84|15\r\n84|18\r\n84|31\r\n84|36\r\n84|22\r\n84|56\r\n84|11\r\n84|72\r\n84|71\r\n84|37\r\n84|54\r\n84|96\r\n84|64\r\n36|55\r\n36|79\r\n36|42\r\n36|77\r\n36|34\r\n36|25\r\n36|14\r\n36|17\r\n36|97\r\n36|44\r\n36|53\r\n36|21\r\n36|89\r\n36|88\r\n36|24\r\n36|51\r\n36|32\r\n36|67\r\n36|19\r\n36|59\r\n36|66\r\n36|13\r\n36|98\r\n36|78\r\n79|34\r\n79|37\r\n79|18\r\n79|59\r\n79|98\r\n79|17\r\n79|13\r\n79|89\r\n79|66\r\n79|97\r\n79|19\r\n79|24\r\n79|78\r\n79|25\r\n79|84\r\n79|14\r\n79|31\r\n79|32\r\n79|77\r\n79|55\r\n79|51\r\n79|67\r\n79|42\r\n79|44\r\n88|34\r\n88|78\r\n88|59\r\n88|31\r\n88|42\r\n88|37\r\n88|66\r\n88|32\r\n88|79\r\n88|55\r\n88|25\r\n88|98\r\n88|51\r\n88|89\r\n88|77\r\n88|19\r\n88|67\r\n88|17\r\n88|97\r\n88|44\r\n88|14\r\n88|24\r\n88|84\r\n88|13\r\n47|36\r\n47|19\r\n47|79\r\n47|51\r\n47|14\r\n47|17\r\n47|89\r\n47|21\r\n47|88\r\n47|66\r\n47|77\r\n47|78\r\n47|24\r\n47|97\r\n47|42\r\n47|53\r\n47|25\r\n47|32\r\n47|59\r\n47|34\r\n47|13\r\n47|98\r\n47|55\r\n47|44\r\n72|62\r\n72|68\r\n72|85\r\n72|64\r\n72|36\r\n72|11\r\n72|71\r\n72|22\r\n72|56\r\n72|47\r\n72|49\r\n72|53\r\n72|76\r\n72|21\r\n72|87\r\n72|88\r\n72|27\r\n72|54\r\n72|79\r\n72|15\r\n72|94\r\n72|23\r\n72|33\r\n72|96\r\n19|33\r\n19|49\r\n19|72\r\n19|84\r\n19|17\r\n19|15\r\n19|31\r\n19|94\r\n19|34\r\n19|67\r\n19|76\r\n19|23\r\n19|18\r\n19|22\r\n19|66\r\n19|85\r\n19|32\r\n19|62\r\n19|13\r\n19|78\r\n19|37\r\n19|56\r\n19|51\r\n19|98\r\n18|56\r\n18|11\r\n18|72\r\n18|88\r\n18|87\r\n18|53\r\n18|96\r\n18|62\r\n18|49\r\n18|15\r\n18|27\r\n18|33\r\n18|64\r\n18|76\r\n18|22\r\n18|85\r\n18|21\r\n18|54\r\n18|71\r\n18|23\r\n18|47\r\n18|94\r\n18|36\r\n18|68\r\n71|14\r\n71|88\r\n71|17\r\n71|19\r\n71|44\r\n71|42\r\n71|77\r\n71|54\r\n71|11\r\n71|79\r\n71|66\r\n71|59\r\n71|36\r\n71|55\r\n71|64\r\n71|53\r\n71|97\r\n71|24\r\n71|21\r\n71|25\r\n71|89\r\n71|47\r\n71|34\r\n71|98\r\n33|23\r\n33|94\r\n33|11\r\n33|71\r\n33|54\r\n33|68\r\n33|47\r\n33|55\r\n33|62\r\n33|22\r\n33|96\r\n33|87\r\n33|27\r\n33|89\r\n33|64\r\n33|59\r\n33|88\r\n33|77\r\n33|76\r\n33|15\r\n33|53\r\n33|21\r\n33|36\r\n33|79\r\n23|59\r\n23|11\r\n23|25\r\n23|68\r\n23|42\r\n23|47\r\n23|27\r\n23|79\r\n23|55\r\n23|64\r\n23|62\r\n23|21\r\n23|36\r\n23|77\r\n23|54\r\n23|53\r\n23|14\r\n23|89\r\n23|15\r\n23|71\r\n23|88\r\n23|96\r\n23|94\r\n23|87\r\n77|42\r\n77|19\r\n77|37\r\n77|18\r\n77|17\r\n77|85\r\n77|44\r\n77|51\r\n77|72\r\n77|31\r\n77|32\r\n77|84\r\n77|14\r\n77|98\r\n77|25\r\n77|24\r\n77|67\r\n77|97\r\n77|13\r\n77|49\r\n77|34\r\n77|66\r\n77|56\r\n77|78\r\n24|32\r\n24|33\r\n24|98\r\n24|22\r\n24|49\r\n24|37\r\n24|31\r\n24|13\r\n24|23\r\n24|51\r\n24|78\r\n24|66\r\n24|34\r\n24|85\r\n24|19\r\n24|56\r\n24|62\r\n24|18\r\n24|15\r\n24|76\r\n24|17\r\n24|67\r\n24|84\r\n24|72\r\n44|22\r\n44|13\r\n44|51\r\n44|76\r\n44|23\r\n44|19\r\n44|32\r\n44|56\r\n44|97\r\n44|17\r\n44|24\r\n44|84\r\n44|66\r\n44|18\r\n44|78\r\n44|34\r\n44|31\r\n44|37\r\n44|85\r\n44|72\r\n44|33\r\n44|98\r\n44|67\r\n44|49\r\n59|24\r\n59|77\r\n59|44\r\n59|25\r\n59|67\r\n59|14\r\n59|51\r\n59|78\r\n59|18\r\n59|72\r\n59|17\r\n59|37\r\n59|56\r\n59|66\r\n59|34\r\n59|84\r\n59|19\r\n59|31\r\n59|13\r\n59|42\r\n59|89\r\n59|32\r\n59|98\r\n59|97\r\n13|54\r\n13|18\r\n13|72\r\n13|27\r\n13|11\r\n13|62\r\n13|68\r\n13|94\r\n13|87\r\n13|67\r\n13|64\r\n13|15\r\n13|33\r\n13|37\r\n13|76\r\n13|84\r\n13|31\r\n13|56\r\n13|96\r\n13|49\r\n13|85\r\n13|22\r\n13|71\r\n13|23\r\n11|32\r\n11|21\r\n11|77\r\n11|34\r\n11|17\r\n11|89\r\n11|98\r\n11|36\r\n11|79\r\n11|97\r\n11|78\r\n11|42\r\n11|66\r\n11|88\r\n11|24\r\n11|19\r\n11|51\r\n11|47\r\n11|55\r\n11|14\r\n11|59\r\n11|25\r\n11|53\r\n11|44\r\n14|51\r\n14|97\r\n14|78\r\n14|33\r\n14|72\r\n14|25\r\n14|31\r\n14|17\r\n14|44\r\n14|42\r\n14|24\r\n14|84\r\n14|66\r\n14|19\r\n14|56\r\n14|13\r\n14|37\r\n14|18\r\n14|98\r\n14|34\r\n14|32\r\n14|67\r\n14|85\r\n14|49\r\n34|31\r\n34|78\r\n34|37\r\n34|23\r\n34|15\r\n34|68\r\n34|49\r\n34|67\r\n34|51\r\n34|76\r\n34|85\r\n34|96\r\n34|56\r\n34|33\r\n34|94\r\n34|84\r\n34|87\r\n34|22\r\n34|27\r\n34|72\r\n34|18\r\n34|13\r\n34|32\r\n34|62\r\n42|18\r\n42|51\r\n42|76\r\n42|56\r\n42|66\r\n42|44\r\n42|97\r\n42|13\r\n42|33\r\n42|72\r\n42|25\r\n42|34\r\n42|17\r\n42|24\r\n42|31\r\n42|84\r\n42|85\r\n42|37\r\n42|78\r\n42|19\r\n42|49\r\n42|98\r\n42|67\r\n42|32\r\n76|59\r\n76|71\r\n76|77\r\n76|15\r\n76|54\r\n76|23\r\n76|22\r\n76|96\r\n76|53\r\n76|14\r\n76|62\r\n76|79\r\n76|21\r\n76|55\r\n76|27\r\n76|64\r\n76|87\r\n76|68\r\n76|36\r\n76|11\r\n76|47\r\n76|89\r\n76|88\r\n76|94\r\n27|25\r\n27|79\r\n27|71\r\n27|42\r\n27|47\r\n27|14\r\n27|53\r\n27|36\r\n27|66\r\n27|11\r\n27|87\r\n27|55\r\n27|21\r\n27|64\r\n27|88\r\n27|54\r\n27|19\r\n27|97\r\n27|59\r\n27|24\r\n27|89\r\n27|77\r\n27|44\r\n27|96\r\n66|32\r\n66|84\r\n66|68\r\n66|98\r\n66|76\r\n66|94\r\n66|15\r\n66|33\r\n66|22\r\n66|72\r\n66|37\r\n66|56\r\n66|85\r\n66|49\r\n66|13\r\n66|31\r\n66|34\r\n66|78\r\n66|51\r\n66|67\r\n66|18\r\n66|23\r\n66|62\r\n66|17\r\n37|27\r\n37|22\r\n37|15\r\n37|11\r\n37|33\r\n37|76\r\n37|23\r\n37|36\r\n37|21\r\n37|49\r\n37|96\r\n37|56\r\n37|68\r\n37|87\r\n37|71\r\n37|62\r\n37|54\r\n37|31\r\n37|64\r\n37|72\r\n37|18\r\n37|94\r\n37|47\r\n37|85\r\n31|47\r\n31|27\r\n31|72\r\n31|23\r\n31|49\r\n31|56\r\n31|54\r\n31|87\r\n31|68\r\n31|71\r\n31|15\r\n31|96\r\n31|22\r\n31|85\r\n31|76\r\n31|36\r\n31|64\r\n31|11\r\n31|18\r\n31|53\r\n31|62\r\n31|33\r\n31|21\r\n98|62\r\n98|32\r\n98|13\r\n98|31\r\n98|85\r\n98|51\r\n98|72\r\n98|27\r\n98|15\r\n98|67\r\n98|22\r\n98|23\r\n98|18\r\n98|33\r\n98|84\r\n98|78\r\n98|94\r\n98|68\r\n98|96\r\n98|56\r\n98|34\r\n98|76\r\n25|67\r\n25|33\r\n25|32\r\n25|13\r\n25|84\r\n25|49\r\n25|72\r\n25|34\r\n25|78\r\n25|98\r\n25|24\r\n25|37\r\n25|85\r\n25|51\r\n25|97\r\n25|66\r\n25|18\r\n25|76\r\n25|19\r\n25|56\r\n25|31\r\n89|49\r\n89|17\r\n89|42\r\n89|67\r\n89|56\r\n89|37\r\n89|97\r\n89|51\r\n89|34\r\n89|77\r\n89|44\r\n89|31\r\n89|25\r\n89|19\r\n89|24\r\n89|98\r\n89|78\r\n89|14\r\n89|18\r\n89|13\r\n97|78\r\n97|66\r\n97|49\r\n97|34\r\n97|17\r\n97|56\r\n97|85\r\n97|37\r\n97|32\r\n97|24\r\n97|19\r\n97|15\r\n97|13\r\n97|18\r\n97|72\r\n97|22\r\n97|98\r\n97|84\r\n97|76\r\n94|42\r\n94|88\r\n94|21\r\n94|27\r\n94|44\r\n94|14\r\n94|77\r\n94|64\r\n94|79\r\n94|87\r\n94|97\r\n94|24\r\n94|68\r\n94|25\r\n94|54\r\n94|59\r\n94|55\r\n94|71\r\n56|85\r\n56|15\r\n56|79\r\n56|21\r\n56|53\r\n56|96\r\n56|47\r\n56|94\r\n56|36\r\n56|54\r\n56|49\r\n56|27\r\n56|87\r\n56|68\r\n56|71\r\n56|22\r\n56|55\r\n67|31\r\n67|18\r\n67|71\r\n67|11\r\n67|96\r\n67|37\r\n67|85\r\n67|15\r\n67|22\r\n67|76\r\n67|27\r\n67|68\r\n67|49\r\n67|94\r\n67|64\r\n67|23\r\n87|77\r\n87|79\r\n87|88\r\n87|17\r\n87|36\r\n87|54\r\n87|25\r\n87|66\r\n87|44\r\n87|14\r\n87|55\r\n87|97\r\n87|59\r\n87|89\r\n87|64\r\n17|22\r\n17|13\r\n17|23\r\n17|67\r\n17|76\r\n17|33\r\n17|31\r\n17|56\r\n17|85\r\n17|98\r\n17|78\r\n17|15\r\n17|34\r\n17|32\r\n32|23\r\n32|84\r\n32|49\r\n32|22\r\n32|62\r\n32|68\r\n32|85\r\n32|27\r\n32|51\r\n32|13\r\n32|37\r\n32|18\r\n32|33\r\n49|54\r\n49|27\r\n49|47\r\n49|11\r\n49|55\r\n49|21\r\n49|64\r\n49|22\r\n49|62\r\n49|94\r\n49|59\r\n49|76\r\n64|21\r\n64|11\r\n64|77\r\n64|19\r\n64|66\r\n64|17\r\n64|47\r\n64|32\r\n64|88\r\n64|14\r\n64|42\r\n96|88\r\n96|54\r\n96|19\r\n96|97\r\n96|59\r\n96|24\r\n96|36\r\n96|89\r\n96|14\r\n96|11\r\n53|25\r\n53|66\r\n53|98\r\n53|37\r\n53|42\r\n53|13\r\n53|97\r\n53|88\r\n53|89\r\n55|32\r\n55|72\r\n55|18\r\n55|17\r\n55|67\r\n55|19\r\n55|37\r\n55|78\r\n54|36\r\n54|98\r\n54|53\r\n54|34\r\n54|66\r\n54|17\r\n54|59\r\n51|62\r\n51|49\r\n51|56\r\n51|67\r\n51|96\r\n51|54\r\n85|33\r\n85|53\r\n85|71\r\n85|76\r\n85|36\r\n22|11\r\n22|64\r\n22|89\r\n22|88\r\n21|44\r\n21|25\r\n21|32\r\n68|42\r\n68|97\r\n62|77\r\n\r\n11,71,68,89,88,79,21,96,47,55,14,27,15,87,23,42,62,64,54,77,94,59,36\r\n87,89,59,36,96,71,44,19,47,55,11,25,54,64,88,14,42,27,97,24,21\r\n79,19,89,59,53,32,13,66,24,98,25,88,44,17,97,21,77,14,51,78,36,55,34\r\n56,49,85,33,76,22,23,15,62,94,68,27,96,87,64,11,36,21,53,88,79\r\n42,25,44,97,24,19,98,34,32,78,13,84,37,31,18,72,56,85,33\r\n47,21,53,88,55,89,77,14,42,25,44,97,19,66,17,98,34,32,51\r\n13,31,56,33,23,27,96,54,64\r\n53,88,55,59,42,25,44,97,24,19,66,17,98,34,32,78,13,67,84\r\n44,68,71,14,64,87,53,27,97,54,94,59,77\r\n77,47,19,34,53\r\n71,19,21,24,11,77,88,25,98,66,89,54,42,53,64\r\n87,71,54,64,36,21,53,59,77,14,42,25,17\r\n37,31,76,96,32,34,49,23,27,51,94,68,18\r\n84,67,23,49,31,51,56,98,33,15,94,76,17,22,13,66,62,32,34\r\n22,23,15,62,27,96,87,71,54,11,47,21,53,79,55,59,89,77,14\r\n33,51,27,94,68,85,23,67,22,13,84,76,15,31,34,49,56,72,18,78,62\r\n79,55,89,14,44,24,98,13,31\r\n85,49,22,56,23,62,71,72,76,68,11,15,94\r\n22,23,15,17,34,68,76\r\n71,87,36,53,68\r\n87,47,36,21,79,55,77,14,42,19,66\r\n94,87,27,33,21,89,76\r\n42,25,44,97,24,19,66,17,98,32,78,51,13,67,37,31,18,72,56,49,85\r\n71,36,79,55,59,89,77,42,24,17,98\r\n19,32,67,18,72,56,49,85,22,15,62\r\n76,85,22,31,18,23,98,15,56,78,66,67,17,51,37,49,34,33,24\r\n27,76,85,22,54,11,96,71,72,87,94,56,36,18,47,33,68,49,53\r\n84,37,31,18,72,56,85,33,76,22,23,15,62,94,68,27,96,87,71,54,64,11,47\r\n67,84,31,72,56,85,76,22,15,94,96,87,71,64,11\r\n64,79,59,71,62,68,21,55,22\r\n49,85,33,22,23,87,71,64,11,47,21,53,55\r\n23,15,68,27,96,87,71,64,47,36,21,88,79,55,59,77,42\r\n19,77,51,31,42,32,34,24,13,97,98,78,67,44,55,89,84,25,66\r\n55,77,24,19,66,34,67,84,37\r\n66,25,89,77,42,13,21,17,32,59,67,53,79,55,24,34,19,97,14\r\n62,68,21,76,54,64,47,87,88,53,96,56,15,72,22,27,11\r\n97,24,19,17,34,32,78,51,13,67,84,31,18,72,56,49,85,33,76,22,23\r\n85,72,87,22,76,33,49,32,51\r\n15,94,27,96,87,54,11,36,21,53,55,59,77,14,42\r\n68,27,96,87,71,54,64,11,47,36,21,53,79,55,59,89,77,14,42,25,44,97,24\r\n32,78,51,13,67,37,18,72,56,76,22,62,27\r\n72,56,49,85,22,62,27,54,11,47,88\r\n88,14,19,87,11,54,25,97,89,21,24,36,59,55,77,71,27,47,96,44,79,53,64\r\n87,76,13,22,15,78,37,51,67,23,18,84,56,72,31,85,33,27,96,62,32,94,68\r\n44,97,24,66,17,98,34,78,13,67,84,37,31,18,72,56,49,85,33,76,22\r\n53,55,59,89,77,25,44,97,24,19,17,98,34,32,78,51,13,67,84\r\n89,25,66,98,78,37,56\r\n44,25,79,98,55,11,24,17,42,71,14,36,54\r\n77,14,54,87,89\r\n19,66,17,98,34,32,78,51,13,67,84,37,31,18,56,33,76,22,23,15,62\r\n33,31,84,18,72,62,13,68,37,27,85,94,87,76,96,67,54,71,51\r\n49,96,78,51,33,62,84,27,32,13,15,56,87,67,37,31,85,22,18,72,94,76,23\r\n22,11,36,88,89,77,14\r\n18,19,84,24,25,44,32,98,85,76,17\r\n84,22,67,18,34,49,76,56,98,37,72\r\n44,97,66,98,32,18,56,85,22\r\n33,76,22,23,15,62,94,68,27,96,87,54,64,11,47,36,21,53,88,79,55,59,89\r\n31,13,98,33,72,84,42,32,51,97,19\r\n32,15,23,66,24,78,76,17,85,34,18\r\n51,84,19,23,78,98,67,72,85,66,24,17,31,97,18,13,56,32,76,37,33\r\n98,78,24,51,77,36,19,47,14,97,66,17,42,34,21,59,44,53,88,25,89\r\n23,67,84,15,13,78,71,37,22\r\n19,66,98,67,31,49,85,23,15\r\n55,66,19,97,34,21,89,17,54\r\n98,13,67,84,37,31,18,76,22,62,68\r\n27,96,54,53,79,55,25\r\n31,18,56,49,33,76,22,23,62,94,68,27,71,64,21\r\n25,79,64,42,53,68,87,15,54,96,94,88,27\r\n17,25,49,72,32,42,18,78,13,19,34,85,33\r\n68,37,23,33,71,85,76,94,62,31,56\r\n53,88,89,42,25,24,19,66,17,78,51,67,84\r\n51,67,84,37,31,18,72,56,49,85,76,23,15,62,94,68,27,96,87,71,54\r\n13,84,31,18,56,49,33,76,22,62,94,68,27,96,71,54,64\r\n37,84,68,94,23,96,15\r\n96,32,84,62,13,27,68,85,37,34,56,31,18,22,49\r\n36,56,68,87,37,85,47,64,49\r\n77,19,17,89,56,42,34\r\n18,76,34,85,97,17,66,98,37,31,51,24,67,32,33,25,78,56,49\r\n42,25,97,24,17,34,78,51,84,18,72,56,85\r\n32,49,66,67,17,72,13,44,22,51,31,78,34,33,76,18,19\r\n55,14,42,44,34,67,84,31,18\r\n96,87,71,64,11,47,21,53,88,79,55,59,89,77,14,42,25,44,97,24,66\r\n55,96,47,44,42,25,66\r\n71,97,17,47,36,14,89,42,44,24,77,66,64,54,11,98,55,19,25\r\n62,36,53,55,14\r\n78,98,19,72,66,31,51,25,49,44,76,32,84,24,18,37,67,97,33\r\n25,97,24,17,98,32,56\r\n97,66,32,49,85,22,23\r\n55,89,77,14,42,25,44,97,17,32,78,51,84,31,18\r\n31,56,85,27,96,87,21\r\n33,76,15,62,87,71,47,36,88,59,89\r\n85,62,37,51,18,31,94,22,32,72,76,34,98,66,33,84,67,17,56,49,78\r\n76,56,49,34,31,67,66,23,62,98,17,18,94,51,78,85,15,33,13\r\n14,42,44,97,24,19,66,98,34,32,37,72,85\r\n15,62,68,27,96,87,71,54,11,21,79,55,59,89,77,14,25\r\n32,78,51,13,84,37,31,18,72,33,76,22,23,15,62,94,68,96,87\r\n11,23,88,59,68,15,47,27,55,22,94,71,33,85,54\r\n84,27,56,11,76,47,37,72,31,64,33\r\n14,42,44,24,98,34,32,78,13,84,31,18,72,56,85\r\n71,23,55,11,79,54,96,33,68,53,36,59,89\r\n18,49,19,84,51,37,32,44,72,56,24,14,77\r\n85,76,22,23,15,62,94,68,27,96,87,54,11,47,36,21,53,88,79,55,59\r\n22,94,27,96,64,11,36,88,79,55,77\r\n66,34,17,53,44,78,11,42,98,79,77,14,59,19,89,25,97\r\n77,14,42,44,97,24,19,66,17,98,34,32,78,51,13,84,31,18,72,56,49\r\n47,36,88,14,44,66,34\r\n89,77,14,42,25,44,97,24,19,66,17,98,34,32,78,51,13,67,84,37,18,72,56\r\n54,53,36,85,11,68,18,76,72,22,21,64,49,27,96\r\n77,59,88,24,47,55,89,66,36,44,25,79,19\r\n23,15,87,71,53,77,42\r\n89,77,14,42,25,44,97,24,19,66,17,78,51,67,84,37,31,72,56\r\n56,94,11,53,64,87,33,96,22,71,47,23,27,79,54\r\n17,32,84,37,18,22,68\r\n49,62,96,36,79\r\n71,94,87,18,64,49,13\r\n17,98,34,32,78,51,13,67,84,37,31,18,56,49,76,23,62\r\n87,68,14,27,89,21,54,79,44,77,88,25,42,36,59,71,62,64,53\r\n64,11,47,36,21,53,88,79,55,59,89,77,14,42,44,97,24,19,66,17,98,34,32\r\n55,14,25,97,24,66,17,51,13,67,18\r\n62,22,33,23,37,72,54,67,18,64,56,15,13,68,84,27,94\r\n67,84,18,33,76,22,23,62,27,96,11\r\n78,51,13,18,72,56,49,85,33,76,23,15,62,94,68,96,71\r\n54,36,59,14,17,98,34\r\n71,64,21,88,79,89,25,97,24,19,98\r\n33,62,87,23,76,51,71,68,22,96,85,31,67,84,54,49,94,27,37,13,72,15,18\r\n31,18,56,23,15,62,94,54,64,47,21\r\n25,78,13,24,88,42,32,44,14,98,89,34,77\r\n51,78,67,55,89,79,77,97,17,88,34,84,98,53,42,14,13,19,44\r\n96,71,54,64,11,47,36,21,53,88,59,89,77,14,42,25,44,97,66\r\n33,84,22,85,23,19,66,34,56,31,72\r\n78,62,84,34,96,37,76,31,51,85,18,94,13,23,67,49,15,27,68\r\n11,22,27,53,68,72,33,23,96,21,94,36,87,85,56,64,49,54,18,76,47,71,62\r\n66,98,24,97,44,42,11,89,64,17,19,21,79,77,34,14,59,47,53,36,88,32,25\r\n94,68,96,87,71,54,64,11,47,36,21,53,88,79,55,59,89,77,14,42,25,44,97\r\n36,15,87,53,54,21,62,33,89,47,68,94,96,64,71\r\n54,97,59,94,88,53,25\r\n23,49,62,15,68,18,76,33,53\r\n79,59,77,14,66,34,31\r\n14,98,84,31,13,55,25,18,77,24,59\r\n64,36,49,76,88,21,94,87,53,72,15,68,47,56,27\r\n97,14,24,79,44,42,89,66,19,47,17,53,55,21,51,98,25,32,78,59,88,34,77\r\n13,96,62,68,78,72,18,27,87,49,51,67,22,56,37,15,84,31,94,71,76,33,23\r\n13,31,18,72,56,49,22,23,15,62,94,68,96,54,64\r\n37,33,64,85,18,62,36\r\n22,85,96,31,21,72,56,62,76,33,87,23,54,64,15\r\n78,24,44,19,34,14,84,53,32\r\n55,59,25,24,32,84,18\r\n64,47,36,21,88,79,55,59,89,77,25,44,97,98,34\r\n98,78,51,13,67,84,37,31,18,72,56,33,76,23,62,94,68\r\n88,79,55,59,89,14,25,97,24,66,98,32,78,13,67,84,37\r\n11,47,36,21,88,55,59,89,77,14,42,25,44,97,17,98,34,32,78\r\n27,56,72,21,68,76,87,85,71,49,23,94,88,54,64\r\n66,32,17,67,42,25,79,44,51,53,19,89,14,13,55,78,77,21,34,98,59,24,88\r\n22,87,11,27,64,96,68,62,89,15,54\r\n98,13,37,25,14,56,85,34,72,97,19,44,49,17,42\r\n77,42,36,47,55,32,97,51,88\r\n44,84,37,97,66,17,77,32,72,78,51,13,18,25,67,14,59\r\n53,97,36,59,13\r\n79,71,11,94,54,56,21\r\n87,71,54,64,11,47,36,21,53,79,55,59,89,77,14,42,25,44,97,24,19,66,17\r\n34,32,78,67,72,49,76,22,96\r\n37,13,51,24,84,72,66,42,77,32,14,25,31,17,67,97,56,98,34,44,89,78,19\r\n77,42,51,72,97,49,19,56,67\r\n98,34,32,78,51,13,67,84,37,31,18,72,56,49,85,33,76,23,15,62,94,68,27\r\n84,31,85,76,23,15,62,94,96,71,47\r\n22,68,53,11,77,59,76,79,89,88,27,62,87,47,71,54,36\r\n19,78,25,79,84,59,24\r\n51,13,67,31,72,56,49,15,27,96,87,71,54\r\n66,98,34,32,67,37,31,18,49,85,23,15,94\r\n53,89,11,54,34,25,47\r\n42,44,97,24,19,34,32,13,67,37,31,18,72,56,49\r\n68,15,27,71,62\r\n96,97,36,24,64,54,66\r\n19,66,17,67,31,18,56,22,23,15,62\r\n47,22,11,76,85,68,62,49,18,21,96,33,27,23,64,15,94,56,87\r\n62,94,27,87,71,54,64,47,36,21,53,88,55,89,77,14,44\r\n32,51,13,67,84,37,18,56,85,33,22,23,62,94,87\r\n89,14,25,44,24,17,78,13,84,37,31,18,72\r\n59,89,77,14,42,32,78,51,13,67,37,31,72\r\n68,49,15,96,54,27,88,79,87,22,94,64,76,23,55\r\n13,37,31,49,33,22,15,62,94,68,27,96,71,54,64\r\n14,51,67,88,55,98,37,13,25\r\n88,79,59,89,14,42,25,44,97,24,19,98,34,32,78,13,67\r\n88,55,89,71,76,62,21,22,47,15,87,59,77,53,79,23,94\r\n55,37,77,19,34,13,51,67,44,32,98,24,78,17,14\r\n96,15,94,84,11,87,72\r\n31,11,47,22,54,23,94,56,87,18,71,27,15\r\n66,17,51,84,37,31,49,33,76,22,94\r\n42,66,34,32,13,37,18,85,33\r\n55,11,36,87,77,47,68,42,62,44,79,96,59,21,25\r\n44,59,24,87,64,53,42,11,68,27,47,79,14,71,25\r\n25,44,24,19,66,17,34,32,78,13,84,37,31,18,72,49,85,33,76\r\n31,18,72,56,85,33,76,23,62,27,54,36,21\r\n25,24,66,17,51,31,49,85,76\r\n98,78,51,13,67,84,37,31,18,72,56,49,33,15,68\r\n78,13,19,84,22,98,23\r\n78,25,37,17,24,97,34,88,66,13,77,51,32,98,89,14,84,59,19,55,67\r\n18,51,84,13,24,59,98,17,97,32,34,44,89,77,19,42,72,25,78\r\n15,62,94,68,27,96,87,71,54,64,11,47,36,21,53,88,55,59,89,77,14,42,25\r\n15,21,55,59,89,14,25\r\n84,56,33,76,23,68,96,64,47\r\n71,66,89,36,87,54,21,55,14,42,19,17,25,88,97,44,47";

        public string example => "47|53\r\n97|13\r\n97|61\r\n97|47\r\n75|29\r\n61|13\r\n75|53\r\n29|13\r\n97|29\r\n53|29\r\n61|53\r\n97|53\r\n61|29\r\n47|13\r\n75|47\r\n97|75\r\n47|61\r\n75|61\r\n47|29\r\n75|13\r\n53|13\r\n\r\n75,47,61,53,29\r\n97,61,53,29,13\r\n75,29,13\r\n75,97,47,61,53\r\n61,13,29\r\n97,13,75,29,47";


        private Dictionary<int, List<int>> Rules(string inputstring)
        {
            string[] rows = inputstring.Split("\r\n");

            Dictionary<int, List<int>> oup = new Dictionary<int, List<int>>();

            foreach (string row in rows)
            {
                if (!row.Contains("|")) break;

                string[] sp = row.Split("|");

                int index = int.Parse(sp[0]);
                int rool = int.Parse(sp[1]);


                if (!oup.ContainsKey(index)) oup.Add(index, new List<int>());

                oup[index].Add(rool);

            }

            return oup;
        }

        private List<List<int>> Updateds(string inp)
        {
            string[] sp = inp.Split("\r\n\r\n");

            string[] rows = sp[1].Split("\r\n");

            List<List<int>> up = new List<List<int>>();

            for (int i = 0; i < rows.Length; i++)
            {
                up.Add(new List<int>());
                string[] nubs = rows[i].Split(',');

                foreach (string nub in nubs)
                {
                    up[i].Add(int.Parse(nub));

                }
            }

            return up;
        }


        void PrintDataToConsole(Dictionary<int, List<int>> inp)
        {
            foreach (KeyValuePair<int, List<int>> rule in inp)
            {
                Console.Write($"{rule.Key}: ");
                foreach (int r in rule.Value)
                {
                    Console.Write(" " + r);
                }
                Console.WriteLine();
            }
        }

        void PrintUpdatedsToConsole(List<List<int>> inp)
        {
            foreach (var item in inp)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1.ToString() + ",");
                }

                Console.WriteLine();
            }
        }

        private int ReturnMiddle(List<int> inp)
        {
            int halve = inp.Count() / 2;
            return inp[halve];
        }

        private int Check(Dictionary<int, List<int>> rules, List<int> data)
        {
            List<int> checkedInts = new List<int>();

            for (int i = 0; i < data.Count; i++) {

                if (rules.ContainsKey(data[i]))
                {
                    foreach (int r in rules[data[i]])
                    {
                        if (data.Contains(r) && checkedInts.Contains(r)) return 0;
                    }
                }
                checkedInts.Add(data[i]);
            }

            Console.WriteLine(ReturnMiddle(checkedInts));
            return ReturnMiddle(checkedInts);

        }


        public string Run(bool UseInput = true)
        {
            Dictionary<int, List<int>> data = UseInput ? Rules(input) : Rules(example);
            List<List<int>> updates = UseInput ? Updateds(input) : Updateds(example);
            int output = 0;

            foreach (var item in updates)
            {
                output += Check(data, item);
            }


            return output.ToString();



        }

        private int Sort(Dictionary<int, List<int>> rules, List<int> data)
        {
            List<int> sortedList = new List<int>();

            while (data.Count > 0) {
                foreach (var item in rules) 
                {
                    if(canBeAdded(ref sortedList, item.Value, ref data))
                    {
                        sortedList.Add(item.Key);
                    }
                }

            }

            return ReturnMiddle(sortedList);
        }


        bool canBeAdded(ref List<int> sortedlist, List<int> rule, ref List<int> data) 
        {

            foreach (int r in rule) { 

                if(!data.Contains(r)) continue;
                if(data.Contains(r) && sortedlist.Contains(r)) continue;
                return false;
            }


            return true;


        }
       


        public string Run2(bool UseInput = true)
        {
            Dictionary<int, List<int>> data = UseInput ? Rules(input) : Rules(example);
            List<List<int>> updates = UseInput ? Updateds(input) : Updateds(example);
            int output = 0;

            foreach (var item in updates)
            {
                
                output += Sort(data, item);
                Console.WriteLine("checked");
            }


            return output.ToString();
        }
    }
}
