# Auto-generated argument completers for parameters of SDK ConstantClass-derived type used in cmdlets.
# Do not modify this file; it may be overwritten during version upgrades.

$psMajorVersion = $PSVersionTable.PSVersion.Major
if ($psMajorVersion -eq 2) 
{ 
	Write-Verbose "Dynamic argument completion not supported in PowerShell version 2; skipping load."
	return 
}

# PowerShell's native Register-ArgumentCompleter cmdlet is available on v5.0 or higher. For lower
# version, we can use the version in the TabExpansion++ module if installed.
$registrationCmdletAvailable = ($psMajorVersion -ge 5) -Or !((Get-Command Register-ArgumentCompleter -ea Ignore) -eq $null)

# internal function to perform the registration using either cmdlet or manipulation
# of the options table
function _awsArgumentCompleterRegistration()
{
    param
    (
        [scriptblock]$scriptBlock,
        [hashtable]$param2CmdletsMap
    )

    if ($registrationCmdletAvailable)
    {
        foreach ($paramName in $param2CmdletsMap.Keys)
        {
             $args = @{
                "ScriptBlock" = $scriptBlock
                "Parameter" = $paramName
            }

            $cmdletNames = $param2CmdletsMap[$paramName]
            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                $args["Command"] = $cmdletNames
            }

            Register-ArgumentCompleter @args
        }
    }
    else
    {
        if (-not $global:options) { $global:options = @{ CustomArgumentCompleters = @{ }; NativeArgumentCompleters = @{ } } }

        foreach ($paramName in $param2CmdletsMap.Keys)
        {
            $cmdletNames = $param2CmdletsMap[$paramName]

            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                foreach ($cn in $cmdletNames)
                {
                    $fqn =  [string]::Concat($cn, ":", $paramName)
                    $global:options['CustomArgumentCompleters'][$fqn] = $scriptBlock
                }
            }
            else
            {
                $global:options['CustomArgumentCompleters'][$paramName] = $scriptBlock
            }
        }

        $function:tabexpansion2 = $function:tabexpansion2 -replace 'End\r\n{', 'End { if ($null -ne $options) { $options += $global:options} else {$options = $global:options}'
    }
}

# To allow for same-name parameters of different ConstantClass-derived types 
# each completer function checks on command name concatenated with parameter name.
# Additionally, the standard code pattern for completers is to pipe through 
# sort-object after filtering against $wordToComplete but we omit this as our members 
# are already sorted.

# Argument completions for service Payment Cryptography Data


$PAYCD_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.PaymentCryptographyData.DukptDerivationType
        {
            ($_ -eq "Protect-PAYCDData/Dukpt_DukptKeyDerivationType") -Or
            ($_ -eq "Unprotect-PAYCDData/Dukpt_DukptKeyDerivationType") -Or
            ($_ -eq "Test-PAYCDPinData/DukptAttributes_DukptDerivationType") -Or
            ($_ -eq "New-PAYCDMac/DukptCmac_DukptDerivationType") -Or
            ($_ -eq "Test-PAYCDMac/DukptCmac_DukptDerivationType") -Or
            ($_ -eq "New-PAYCDMac/DukptIso9797Algorithm1_DukptDerivationType") -Or
            ($_ -eq "Test-PAYCDMac/DukptIso9797Algorithm1_DukptDerivationType") -Or
            ($_ -eq "New-PAYCDMac/DukptIso9797Algorithm3_DukptDerivationType") -Or
            ($_ -eq "Test-PAYCDMac/DukptIso9797Algorithm3_DukptDerivationType") -Or
            ($_ -eq "Convert-PAYCDPinData/IncomingDukptAttributes_DukptKeyDerivationType") -Or
            ($_ -eq "Update-PAYCDEncryptData/IncomingEncryptionAttributes_Dukpt_DukptKeyDerivationType") -Or
            ($_ -eq "Convert-PAYCDPinData/OutgoingDukptAttributes_DukptKeyDerivationType") -Or
            ($_ -eq "Update-PAYCDEncryptData/OutgoingEncryptionAttributes_Dukpt_DukptKeyDerivationType")
        }
        {
            $v = "AES_128","AES_192","AES_256","TDES_2KEY","TDES_3KEY"
            break
        }

        # Amazon.PaymentCryptographyData.DukptEncryptionMode
        {
            ($_ -eq "Protect-PAYCDData/Dukpt_Mode") -Or
            ($_ -eq "Unprotect-PAYCDData/Dukpt_Mode") -Or
            ($_ -eq "Update-PAYCDEncryptData/IncomingEncryptionAttributes_Dukpt_Mode") -Or
            ($_ -eq "Update-PAYCDEncryptData/OutgoingEncryptionAttributes_Dukpt_Mode")
        }
        {
            $v = "CBC","ECB"
            break
        }

        # Amazon.PaymentCryptographyData.DukptKeyVariant
        {
            ($_ -eq "Protect-PAYCDData/Dukpt_DukptKeyVariant") -Or
            ($_ -eq "Unprotect-PAYCDData/Dukpt_DukptKeyVariant") -Or
            ($_ -eq "New-PAYCDMac/DukptCmac_DukptKeyVariant") -Or
            ($_ -eq "Test-PAYCDMac/DukptCmac_DukptKeyVariant") -Or
            ($_ -eq "New-PAYCDMac/DukptIso9797Algorithm1_DukptKeyVariant") -Or
            ($_ -eq "Test-PAYCDMac/DukptIso9797Algorithm1_DukptKeyVariant") -Or
            ($_ -eq "New-PAYCDMac/DukptIso9797Algorithm3_DukptKeyVariant") -Or
            ($_ -eq "Test-PAYCDMac/DukptIso9797Algorithm3_DukptKeyVariant") -Or
            ($_ -eq "Convert-PAYCDPinData/IncomingDukptAttributes_DukptKeyVariant") -Or
            ($_ -eq "Update-PAYCDEncryptData/IncomingEncryptionAttributes_Dukpt_DukptKeyVariant") -Or
            ($_ -eq "Convert-PAYCDPinData/OutgoingDukptAttributes_DukptKeyVariant") -Or
            ($_ -eq "Update-PAYCDEncryptData/OutgoingEncryptionAttributes_Dukpt_DukptKeyVariant")
        }
        {
            $v = "BIDIRECTIONAL","REQUEST","RESPONSE"
            break
        }

        # Amazon.PaymentCryptographyData.EncryptionMode
        {
            ($_ -eq "Update-PAYCDEncryptData/IncomingEncryptionAttributes_Symmetric_Mode") -Or
            ($_ -eq "Update-PAYCDEncryptData/OutgoingEncryptionAttributes_Symmetric_Mode") -Or
            ($_ -eq "Protect-PAYCDData/Symmetric_Mode") -Or
            ($_ -eq "Unprotect-PAYCDData/Symmetric_Mode")
        }
        {
            $v = "CBC","CFB","CFB1","CFB128","CFB64","CFB8","ECB","OFB"
            break
        }

        # Amazon.PaymentCryptographyData.MacAlgorithm
        {
            ($_ -eq "New-PAYCDMac/GenerationAttributes_Algorithm") -Or
            ($_ -eq "Test-PAYCDMac/VerificationAttributes_Algorithm")
        }
        {
            $v = "CMAC","HMAC_SHA224","HMAC_SHA256","HMAC_SHA384","HMAC_SHA512","ISO9797_ALGORITHM1","ISO9797_ALGORITHM3"
            break
        }

        # Amazon.PaymentCryptographyData.MajorKeyDerivationMode
        {
            ($_ -eq "New-PAYCDMac/EmvMac_MajorKeyDerivationMode") -Or
            ($_ -eq "Test-PAYCDMac/EmvMac_MajorKeyDerivationMode") -Or
            ($_ -eq "Test-PAYCDAuthRequestCryptogram/MajorKeyDerivationMode")
        }
        {
            $v = "EMV_OPTION_A","EMV_OPTION_B"
            break
        }

        # Amazon.PaymentCryptographyData.PaddingType
        {
            ($_ -eq "Protect-PAYCDData/Asymmetric_PaddingType") -Or
            ($_ -eq "Unprotect-PAYCDData/Asymmetric_PaddingType") -Or
            ($_ -eq "Update-PAYCDEncryptData/IncomingEncryptionAttributes_Symmetric_PaddingType") -Or
            ($_ -eq "Update-PAYCDEncryptData/OutgoingEncryptionAttributes_Symmetric_PaddingType") -Or
            ($_ -eq "Protect-PAYCDData/Symmetric_PaddingType") -Or
            ($_ -eq "Unprotect-PAYCDData/Symmetric_PaddingType")
        }
        {
            $v = "OAEP_SHA1","OAEP_SHA256","OAEP_SHA512","PKCS1"
            break
        }

        # Amazon.PaymentCryptographyData.PinBlockFormatForPinData
        {
            ($_ -eq "New-PAYCDPinData/PinBlockFormat") -Or
            ($_ -eq "Test-PAYCDPinData/PinBlockFormat")
        }
        {
            $v = "ISO_FORMAT_0","ISO_FORMAT_3"
            break
        }

        # Amazon.PaymentCryptographyData.SessionKeyDerivationMode
        {
            ($_ -eq "New-PAYCDMac/EmvMac_SessionKeyDerivationMode") -Or
            ($_ -eq "Test-PAYCDMac/EmvMac_SessionKeyDerivationMode")
        }
        {
            $v = "AMEX","EMV2000","EMV_COMMON_SESSION_KEY","MASTERCARD_SESSION_KEY","VISA"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$PAYCD_map = @{
    "Asymmetric_PaddingType"=@("Protect-PAYCDData","Unprotect-PAYCDData")
    "Dukpt_DukptKeyDerivationType"=@("Protect-PAYCDData","Unprotect-PAYCDData")
    "Dukpt_DukptKeyVariant"=@("Protect-PAYCDData","Unprotect-PAYCDData")
    "Dukpt_Mode"=@("Protect-PAYCDData","Unprotect-PAYCDData")
    "DukptAttributes_DukptDerivationType"=@("Test-PAYCDPinData")
    "DukptCmac_DukptDerivationType"=@("New-PAYCDMac","Test-PAYCDMac")
    "DukptCmac_DukptKeyVariant"=@("New-PAYCDMac","Test-PAYCDMac")
    "DukptIso9797Algorithm1_DukptDerivationType"=@("New-PAYCDMac","Test-PAYCDMac")
    "DukptIso9797Algorithm1_DukptKeyVariant"=@("New-PAYCDMac","Test-PAYCDMac")
    "DukptIso9797Algorithm3_DukptDerivationType"=@("New-PAYCDMac","Test-PAYCDMac")
    "DukptIso9797Algorithm3_DukptKeyVariant"=@("New-PAYCDMac","Test-PAYCDMac")
    "EmvMac_MajorKeyDerivationMode"=@("New-PAYCDMac","Test-PAYCDMac")
    "EmvMac_SessionKeyDerivationMode"=@("New-PAYCDMac","Test-PAYCDMac")
    "GenerationAttributes_Algorithm"=@("New-PAYCDMac")
    "IncomingDukptAttributes_DukptKeyDerivationType"=@("Convert-PAYCDPinData")
    "IncomingDukptAttributes_DukptKeyVariant"=@("Convert-PAYCDPinData")
    "IncomingEncryptionAttributes_Dukpt_DukptKeyDerivationType"=@("Update-PAYCDEncryptData")
    "IncomingEncryptionAttributes_Dukpt_DukptKeyVariant"=@("Update-PAYCDEncryptData")
    "IncomingEncryptionAttributes_Dukpt_Mode"=@("Update-PAYCDEncryptData")
    "IncomingEncryptionAttributes_Symmetric_Mode"=@("Update-PAYCDEncryptData")
    "IncomingEncryptionAttributes_Symmetric_PaddingType"=@("Update-PAYCDEncryptData")
    "MajorKeyDerivationMode"=@("Test-PAYCDAuthRequestCryptogram")
    "OutgoingDukptAttributes_DukptKeyDerivationType"=@("Convert-PAYCDPinData")
    "OutgoingDukptAttributes_DukptKeyVariant"=@("Convert-PAYCDPinData")
    "OutgoingEncryptionAttributes_Dukpt_DukptKeyDerivationType"=@("Update-PAYCDEncryptData")
    "OutgoingEncryptionAttributes_Dukpt_DukptKeyVariant"=@("Update-PAYCDEncryptData")
    "OutgoingEncryptionAttributes_Dukpt_Mode"=@("Update-PAYCDEncryptData")
    "OutgoingEncryptionAttributes_Symmetric_Mode"=@("Update-PAYCDEncryptData")
    "OutgoingEncryptionAttributes_Symmetric_PaddingType"=@("Update-PAYCDEncryptData")
    "PinBlockFormat"=@("New-PAYCDPinData","Test-PAYCDPinData")
    "Symmetric_Mode"=@("Protect-PAYCDData","Unprotect-PAYCDData")
    "Symmetric_PaddingType"=@("Protect-PAYCDData","Unprotect-PAYCDData")
    "VerificationAttributes_Algorithm"=@("Test-PAYCDMac")
}

_awsArgumentCompleterRegistration $PAYCD_Completers $PAYCD_map

$PAYCD_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.PAYCD.$($commandName.Replace('-', ''))Cmdlet]"
    if (-not $cmdletType) {
        return
    }
    $awsCmdletAttribute = $cmdletType.GetCustomAttributes([Amazon.PowerShell.Common.AWSCmdletAttribute], $false)
    if (-not $awsCmdletAttribute) {
        return
    }
    $type = $awsCmdletAttribute.SelectReturnType
    if (-not $type) {
        return
    }

    $splitSelect = $wordToComplete -Split '\.'
    $splitSelect | Select-Object -First ($splitSelect.Length - 1) | ForEach-Object {
        $propertyName = $_
        $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')) | Where-Object { $_.Name -ieq $propertyName }
        if ($properties.Length -ne 1) {
            break
        }
        $type = $properties.PropertyType
        $prefix += "$($properties.Name)."

        $asEnumerableType = $type.GetInterface('System.Collections.Generic.IEnumerable`1')
        if ($asEnumerableType -and $type -ne [System.String]) {
            $type =  $asEnumerableType.GetGenericArguments()[0]
        }
    }

    $v = @( '*' )
    $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')).Name | Sort-Object
    if ($properties) {
        $v += ($properties | ForEach-Object { $prefix + $_ })
    }
    $parameters = $cmdletType.GetProperties(('Instance', 'Public')) | Where-Object { $_.GetCustomAttributes([System.Management.Automation.ParameterAttribute], $true) } | Select-Object -ExpandProperty Name | Sort-Object
    if ($parameters) {
        $v += ($parameters | ForEach-Object { "^$_" })
    }

    $v |
        Where-Object { $_ -match "^$([System.Text.RegularExpressions.Regex]::Escape($wordToComplete)).*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$PAYCD_SelectMap = @{
    "Select"=@("Unprotect-PAYCDData",
               "Protect-PAYCDData",
               "New-PAYCDCardValidationData",
               "New-PAYCDMac",
               "New-PAYCDPinData",
               "Update-PAYCDEncryptData",
               "Convert-PAYCDPinData",
               "Test-PAYCDAuthRequestCryptogram",
               "Test-PAYCDCardValidationData",
               "Test-PAYCDMac",
               "Test-PAYCDPinData")
}

_awsArgumentCompleterRegistration $PAYCD_SelectCompleters $PAYCD_SelectMap

