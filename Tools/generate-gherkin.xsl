<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="text" version="1.0" encoding="utf-16" indent="no"/>

   
    
    <xsl:key name="scenarios" match="/assemblies/assembly/collection/test" use="@method"/>

    
    <xsl:template match="collection">

    Generated : <xsl:value-of select="/assemblies/@timestamp"/><xsl:text>&#13;&#10;</xsl:text>    
        <xsl:for-each select="test[generate-id() = generate-id(key('scenarios', @method)[1])]">
            <xsl:sort select="@method" />
    Scenario <xsl:value-of select="translate(@method,'_',' ')" /><xsl:text>&#13;&#10;</xsl:text>
            <xsl:for-each select="key('scenarios', @method)">
                <xsl:variable name="gherkin" select="substring-after(@name, '] ' )" />
                <xsl:choose>
                    <xsl:when test="starts-with($gherkin,'(Background)')">
                        <xsl:text>Background&#13;&#10; </xsl:text> <xsl:value-of select="substring-after($gherkin,'(Background) ')" /><xsl:text>&#13;&#10;</xsl:text>
                    </xsl:when>
                    <xsl:otherwise>
                        <xsl:choose>
                            <xsl:when test="starts-with($gherkin,'And')">
                                <xsl:text>        </xsl:text><xsl:value-of select="$gherkin" /><xsl:text>&#13;&#10;</xsl:text>
                            </xsl:when>
                            <xsl:otherwise>
                                <xsl:text>      </xsl:text><xsl:value-of select="$gherkin" /><xsl:text>&#13;&#10;</xsl:text>
                            </xsl:otherwise>
                        </xsl:choose>
                    </xsl:otherwise>
                </xsl:choose>
            </xsl:for-each>
        </xsl:for-each>
        
        
     
        
    </xsl:template>

</xsl:stylesheet>