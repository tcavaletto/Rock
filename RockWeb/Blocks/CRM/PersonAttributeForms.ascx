﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PersonAttributeForms.ascx.cs" Inherits="RockWeb.Blocks.Crm.PersonAttributeForms" %>

<script type="text/javascript">
    function clearActiveDialog() {
        $('#<%=hfActiveDialog.ClientID %>').val('');
    }
</script>

<asp:UpdatePanel ID="upnlContent" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
    <ContentTemplate>

        <asp:HiddenField ID="hfTriggerScroll" runat="server" Value="" />

        <asp:ValidationSummary ID="vsSummary" runat="server" HeaderText="Please Correct the Following" CssClass="alert alert-danger" />
        <Rock:NotificationBox ID="nbMain" runat="server" Visible="false"></Rock:NotificationBox>

        <%-- View Panel --%>
        <asp:Panel ID="pnlView" runat="server" Visible="false">

            <h1><asp:Literal ID="lTitle" runat="server" /></h1>
        
            <asp:Panel ID="pnlProgressBar" runat="server">
                <div class="progress">
                    <div class="progress-bar" role="progressbar" aria-valuenow="<%=this.PercentComplete%>" aria-valuemin="0" aria-valuemax="100" style="width: <%=this.PercentComplete%>%;">
                        <span class="sr-only"><%=this.PercentComplete%>% Complete</span>
                    </div>
                </div>
            </asp:Panel>

            <asp:Literal ID="lHeader" runat="server" />

            <asp:PlaceHolder ID="phContent" runat="server" />

            <asp:Literal ID="lFooter" runat="server" />

            <div class="actions">
                <asp:LinkButton ID="lbPrev" runat="server" AccessKey="p" Text="Previous" CssClass="btn btn-default" CausesValidation="false" OnClick="lbPrev_Click"  />
                <Rock:BootstrapButton ID="lbNext" runat="server" AccessKey="n" Text="Next" DataLoadingText="Next" CssClass="btn btn-primary pull-right" CausesValidation="true" OnClick="lbNext_Click" />
            </div>

        </asp:Panel>

        <%-- Edit Panel --%>
        <asp:Panel ID="pnlEdit" runat="server" Visible="false" CssClass="panel panel-block">
            <div class="panel-heading"></div>
            <div class="panel-body">

                <div class="panel panel-default contribution-info">
                    <div class="panel-heading"><h3 class="panel-title">Forms</h3></div>
                    <div class="panel-body">

                        <asp:PlaceHolder ID="phForms" runat="server" />

                        <div class="pull-right">
                            <asp:LinkButton ID="lbAddForm" runat="server" CssClass="btn btn-action btn-xs" OnClick="lbAddForm_Click" CausesValidation="false"><i class="fa fa-plus"></i> Add Form</asp:LinkButton>
                        </div>

                        <div class="actions">
                            <asp:LinkButton ID="btnSave" runat="server" AccessKey="s" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                            <asp:LinkButton ID="btnCancel" runat="server" AccessKey="c" Text="Cancel" CssClass="btn btn-link" CausesValidation="false" OnClick="btnCancel_Click" />
                        </div>

                     </div>
                </div>

            </div>
       </asp:Panel>

        <asp:HiddenField ID="hfActiveDialog" runat="server" />

        <Rock:ModalDialog ID="dlgField" runat="server" Title="Form Field" OnSaveClick="dlgField_SaveClick" OnCancelScript="clearActiveDialog();" ValidationGroup="Field">
            <Content>
                <asp:HiddenField ID="hfFormGuid" runat="server" />
                <asp:HiddenField ID="hfAttributeGuid" runat="server" />
                <asp:ValidationSummary ID="ValidationSummaryAttribute" runat="server" HeaderText="Please Correct the Following" CssClass="alert alert-danger" ValidationGroup="Field" />
                <div class="row">
                    <div class="col-md-4">
                        <Rock:RockDropDownList ID="ddlPersonAttributes" runat="server" Label="Person Attribute" ValidationGroup="Field" />
                    </div>
                    <div class="col-md-4">
                        <Rock:RockCheckBox ID="cbUsePersonCurrentValue" runat="server" Label="Use Current Value" Text="Yes" ValidationGroup="Field"
                            Help="Should the person's current value for this field be displayed (pre-filled)?" />
                    </div>
                    <div class="col-md-4">
                        <Rock:RockCheckBox ID="cbRequireInInitialEntry" runat="server" Label="Required" Text="Yes" ValidationGroup="Field"
                            Help="Should a value for this attribute be required?" />
                    </div>
                </div>
                <Rock:CodeEditor ID="ceAttributePreText" runat="server" Label="Pre-Text" EditorMode="Html" EditorTheme="Rock" EditorHeight="100" ValidationGroup="Field"
                    Help="Any HTML to display directly above this field <span class='tip tip-lava'></span>." />
                <Rock:CodeEditor ID="ceAttributePostText" runat="server" Label="Post-Text" EditorMode="Html" EditorTheme="Rock" EditorHeight="100" ValidationGroup="Field"
                    Help="Any HTML to display directly below this field <span class='tip tip-lava'></span>." />
           </Content>
        </Rock:ModalDialog>
    </ContentTemplate>
</asp:UpdatePanel>
