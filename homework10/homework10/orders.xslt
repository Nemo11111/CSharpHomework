<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/ArrayOfOrder">
       <html>
         <body>
         <table border="1">
           <th>
             orderId
           </th>
           <th>
             customerName
           </th>
           <th>
             Amount
           </th>
           <th>
             orderDetailId
           </th>
           <th>
             phoneNum
           </th>
           <th>
             GoodsName
           </th>
           <th>
             Price
           </th>
           <th>
             Quantity
           </th>
           <xsl:for-each select="Order">
             <tr>
                 <td> 
                   <xsl:value-of select="Id" />
                 </td>
               <td>
                 <xsl:for-each select="Customer">
                     <xsl:value-of select="Name" />
                 </xsl:for-each>
               </td>
               <td>
                 <xsl:value-of select="Amount" />
               </td>
               <td>
                 <xsl:for-each select="Details">
                   <xsl:for-each select="OrderDetail">
                     <xsl:value-of select="Id" />
                   </xsl:for-each>
                 </xsl:for-each>
               </td>
               <td>
                 <xsl:for-each select="Customer">
                     <xsl:value-of select="Id" />
                 </xsl:for-each>

               </td>
               <td>
                 <xsl:for-each select="Details">
                   <xsl:for-each select="OrderDetail">
                     <xsl:for-each select="Goods">
                       <xsl:value-of select="Name" />
                     </xsl:for-each>
                   </xsl:for-each>
                 </xsl:for-each>
               </td>
               <td>
                 <xsl:for-each select="Details">
                   <xsl:for-each select="OrderDetail">
                     <xsl:for-each select="Goods">
                       <xsl:value-of select="Price" />
                     </xsl:for-each>
                   </xsl:for-each>
                 </xsl:for-each>
               </td>
               <td>
                 <xsl:for-each select="Details">
                   <xsl:for-each select="OrderDetail">
                     <xsl:value-of select="Quantity" />
                   </xsl:for-each>
                 </xsl:for-each>
               </td>
               
             </tr>
           </xsl:for-each>
         </table>
         </body>
       </html>
    </xsl:template>
</xsl:stylesheet>
